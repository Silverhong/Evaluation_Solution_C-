using EvaluationSolution.Entity;
using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EvaluationSolution.Infrastructure
{
    public static class ApiExtenstion
    {
        //Get
        public static bool Get<T>(this string url,ref List<T> list)
        {
            try {
                using (HttpClient client = new HttpClient())
                {
                    client.BaseAddress = new Uri(url);
                    var con = client.GetAsync(url).Result;
                    if (con.IsSuccessStatusCode)
                    {
                        string content = con.Content.ReadAsStringAsync().Result;
                        list = JsonConvert.DeserializeObject<List<T>>(content); 
                        return true;
                    }
                    return false;
                }
            } catch (Exception) {
                return false;
            }
        }
        //POST
        public static bool Post<T>(this string url,string JSON)
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    client.BaseAddress = new Uri(url);
                    var content = new StringContent(JSON, Encoding.UTF8, "application/json");
                    var con = client.PostAsync(url, content).Result;
                    if (con.IsSuccessStatusCode)
                    {
                        return true;
                    }
                    return false;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }public static bool Post<T>(this string url,string JSON,ref string response)
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    client.BaseAddress = new Uri(url);
                    var content = new StringContent(JSON, Encoding.UTF8, "application/json");
                    var con = client.PostAsync(url, content).Result;
                    if (con.IsSuccessStatusCode)
                    {
                        response = con.Content.ReadAsStringAsync().Result;
                        return true;
                    }
                    return false;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }
        //DELETE
        public static bool Detete<T>(this string url)
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    client.BaseAddress = new Uri(url);
                    var con = client.DeleteAsync(url).Result;
                    if (con.IsSuccessStatusCode)
                    {
                        return true;
                    }
                    return false;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }
        public static string GetQueryString<T>(this T obj)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append('?');
            IEnumerable data = obj as IEnumerable ?? new[] { obj };

            foreach (var datum in data)
            {
                Type t = datum.GetType();
                var properties = t.GetProperties();
                foreach (PropertyInfo p in properties)
                {
                    if (p.CanRead)
                    {
                        if (p.GetValue(obj,null).ToString() == "")
                            continue;
                        var indexes = p.GetIndexParameters();
                        if (indexes.Count() > 0)
                        {
                            var pp = p.GetValue(datum, new object[] { 1 });
                            sb.Append(GetQueryString(pp));
                        }
                        //else if (typeof(IEnumerable).IsAssignableFrom(p.PropertyType) && p.PropertyType != typeof(string))
                        //{
                        //    sb.Append(GetQueryString(p.GetValue(datum)));
                        //}
                        else
                        {

                            //I dont think this is a good way to do it
                            if (p.GetValue(datum, null) != null && p.PropertyType.FullName != p.GetValue(datum, null).ToString())
                            {
                                //sb.Append(String.Format("{0}={1}&", p.Name, HttpUtility.UrlEncode(p.GetValue(datum, null).ToString())));
                                sb.Append(String.Format("{0}={1}&", p.Name, p.GetValue(datum, null).ToString()));
                            }
                            //else
                            //{
                            //    sb.Append(GetQueryString(p.GetValue(datum, null)));
                            //}
                        }
                    }
                }
            }
            return sb.ToString().TrimEnd('&');
        }
    }
}

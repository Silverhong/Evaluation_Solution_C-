using EvaluationSolution.Entity;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EvaluationSolution.Infrastructure
{
    public static class ApiExtenstion
    {
        public static bool Get<T>(this string url,DataGridView dataGridView=null)
        {
            try {
                using (HttpClient client = new HttpClient())
                {
                    client.BaseAddress = new Uri(url);
                    var con = client.GetAsync(url).Result;
                    if (con.IsSuccessStatusCode)
                    {
                        string content = con.Content.ReadAsStringAsync().Result;
                        dataGridView.DataSource = JsonConvert.DeserializeObject<List<T>>(content);
                        return true;
                    }
                    return false;
                }
            } catch (Exception) {
                return false;
            }
        }
    }
}

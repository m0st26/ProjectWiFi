using System;
using System.Collections.Generic;
using System.Net;
using ParkWifi.DomainObjects;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.IO;
using System.Text;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Unicode;
using ParkWifi.InfrastructureServices.Gateways.Database;
namespace ParkWifi.ApplicationServices.Synchronization
{
    public class ParkWifi_Cell
    {
        public int global_id { get; set; }
        public int Number { get; set; }
        public ParkWifi_inf Cells { get; set; }   
    }

    public class ParkWifi_inf
    {
        public long global_id { get; set; }
        public string FunctionFlag { get; set; }
        public string Name { get; set; }
        public string ParkName { get; set; }
        public string wifiName { get; set; }
    }

    public class UseCaseParkWifi
    {
        static string remoteUri = "https://apidata.mos.ru/v1/datasets/861/rows?api_key=5720beead2a7fc01045f45bdf0d8e3be&$top=1000";

        string path = @".\update_database\parkwifi-";
        
        List<ParkWifi_Cell> parkwifi_cells;

        public List<parkwifi> parkwifis = new List<parkwifi>();

        public UseCaseParkWifi()
        {
            WebRequest request = WebRequest.Create(remoteUri);
            WebResponse response = request.GetResponse();

            StreamReader stream = new StreamReader(response.GetResponseStream());
            string line = stream.ReadToEnd();
            JArray jsonArray = JArray.Parse(line);
            parkwifi_cells = JsonConvert.DeserializeObject<List<ParkWifi_Cell>>(jsonArray.ToString());
            DateTime Date_update = DateTime.Now;
            string date_update = Date_update.ToShortDateString();
            path = path + date_update + @".json";
            using (FileStream fs2 = new FileStream(path, FileMode.OpenOrCreate))
            {
                var options = new JsonSerializerOptions
                {
                    Encoder = JavaScriptEncoder.Create(UnicodeRanges.BasicLatin, UnicodeRanges.Cyrillic),
                    WriteIndented = true
                };
                string text = "[";
                byte[] input = Encoding.Default.GetBytes(text);
                fs2.Write(input, 0, input.Length);
                text = ",";
                for (int i = 0; i < parkwifi_cells.Count; i++)
                {
                    parkwifis.Add(new parkwifi()
                    {
                        Name = parkwifi_cells[i].Cells.Name,
                        Id = parkwifi_cells[i].Number,
                        ParkName = parkwifi_cells[i].Cells.ParkName,
                        FunctionFlag = parkwifi_cells[i].Cells.FunctionFlag,
                        wifiName = parkwifi_cells[i].Cells.wifiName,
                    });

                    System.Text.Json.JsonSerializer.SerializeAsync<parkwifi>(fs2, parkwifis[i], options).GetAwaiter().GetResult();

                    if (i != parkwifi_cells.Count - 1)
                    {
                        input = Encoding.Default.GetBytes(text);
                        fs2.Write(input, 0, input.Length);
                    }
                }
                text = "]";
                input = Encoding.Default.GetBytes(text);
                fs2.Write(input, 0, input.Length);
            }   
        }
    }
}


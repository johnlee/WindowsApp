using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsApp.Models
{
    public class ApiModel
    {
        private string _apiUrl;

        public ApiModel(string apiUrl)
        {
            _apiUrl = apiUrl;
            DataType = "JSON";
            DataContent = WebService.GetWebResponse(apiUrl);
        }

        public string DataContent { get; set; }
        public string DataType { get; set; }
    }
}

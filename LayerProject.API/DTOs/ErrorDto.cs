using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LayerProject.API.DTOs
{
    public class ErrorDto
    {
        public ErrorDto()
        {
            Errors = new List<string>();
        }
        /*
         List<String> Errors den bir nesne örneği oluşturmamız gerekmektedir. Bu sayede List in içi 
        doldurulabilir.
         */
        public List<String> Errors { get; set; }
        public int Status { get; set; }
    }
}

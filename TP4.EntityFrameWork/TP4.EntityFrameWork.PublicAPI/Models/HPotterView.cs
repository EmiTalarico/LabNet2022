using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TP4.EntityFrameWork.PublicAPI.Models
{
    public class HPotterView
    {
        public string Name { get; set; }
        public string Species { get; set; }
        public string Gender { get; set; }
        public string House { get; set; }
        public string DateOfBirth { get; set; }
        public object YearOfBirth { get; set; }
        public bool Wizard { get; set; }
        public string Ancestry { get; set; }
        public string Patronus { get; set; }
        public bool HogwartsStudent { get; set; }
        public bool HogwartsStaff { get; set; }
        public string Actor { get; set; }
        public bool Alive { get; set; }
        public string Image { get; set; }
        public string UrlBase { get => urlBase; set => urlBase = value; }
        public string EndPoint { get => endPoint; set => endPoint = value; }

        private string urlBase = "http://hp-api.herokuapp.com/";
        private string endPoint = "api/characters";

    }
}
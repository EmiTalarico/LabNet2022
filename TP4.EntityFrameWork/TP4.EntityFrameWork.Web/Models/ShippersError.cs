using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TP4.EntityFrameWork.Web.Models
{
    public class ShippersError : AbstractValidator<ShippersView>
    {   
        public ShippersError()
        {
            RuleFor(model => model.Nombre).NotEmpty().WithMessage("El nombre es obligatorio.");
            RuleFor(model => model.Nombre).Length(3,30).WithMessage("El nombre debe contener entre 3 y 30 caracteres.");
            RuleFor(model => model.telefono).NotEmpty().WithMessage("El telefono es obligatorio");
            RuleFor(model => model.telefono).Length(8, 25).WithMessage("El telefono debe contener entre 8 y 25 caracteres");    
        }
    }
}
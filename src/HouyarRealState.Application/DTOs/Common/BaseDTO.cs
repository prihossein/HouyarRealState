using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace HouyarRealState.Application.DTOs.Common
{
    public class BaseDTO
    {
        public Guid Id { get; set; }
        public bool IsDelete { get; set; }
    }
}

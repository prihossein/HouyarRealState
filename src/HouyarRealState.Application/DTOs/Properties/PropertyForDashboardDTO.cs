using System;
using System.Collections.Generic;
using System.Text;
using HouyarRealState.Domain.Entities.Properties;

namespace HouyarRealState.Application.DTOs.Properties
{
    public class PropertyForDashboardDTO
    {
        public Tuple<List<Property>, int> Properties { get; set; }
        public List<PropertyRequestType> PropertyRequestTypes { get; set; } = new List<PropertyRequestType>();
        public List<PropertyType> PropertyTypes { get; set; } = new List<PropertyType>();
        public List<TransactionType> TransactionTypes { get; set; } = new List<TransactionType>();

        public int CountProperties { get; set; }
    }
}

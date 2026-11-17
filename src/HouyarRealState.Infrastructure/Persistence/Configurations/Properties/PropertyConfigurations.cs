using HouyarRealState.Domain.Entities.User;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HouyarRealState.Infrastructure.Persistence.Configurations.Properties
{
    public class PropertyConfigurations : IEntityTypeConfiguration<HouyarRealState.Domain.Entities.Properties.Property>
    {
        public void Configure(EntityTypeBuilder<HouyarRealState.Domain.Entities.Properties.Property> builder)
        {


        }
    }
}

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShareAGame.DataAccess.Entities;
using System;

namespace ShareAGame.DataAccess.Configurations
{
    public class PublisherConfiguration : IEntityTypeConfiguration<Publisher>
    {
        public void Configure(EntityTypeBuilder<Publisher> builder)
        {
            builder.HasData(
                new Publisher
                {
                    Id = new Guid("7c7bc643-b767-4614-8724-fe96ecc57eb2"),
                    Name = "Ubisoft",
                },

                new Publisher
                {
                    Id = new Guid("82642b42-06f4-43e5-847c-5433ce42b31b"),
                    Name = "Square Enix",
                }
                    );
        }
    }
}

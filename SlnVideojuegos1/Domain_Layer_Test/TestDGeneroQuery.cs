using System.Collections.Generic;
using Domain_Layer.Dtos;
using Domain_Layer.Queries;
using NSubstitute;
using NSubstitute.ReturnsExtensions;
using Xunit;

namespace Domain_Layer_Test
{
    public class TestDGeneroQuery
    {
        [Fact]
        public void FindOk()
        {
            var querySubstitute = Substitute.For<IDGeneroQuery>();
            var dtoSubstitute = Substitute.For<DGeneroDto>();
            dtoSubstitute.Id = 1;
            querySubstitute.Find(dtoSubstitute)
                .Returns(new DGeneroDto { Id = 1, Nombre = "RPG"});
        }

        [Fact]
        public void FindErrorSinParametro()
        {
            var querySubstitute = Substitute.For<IDGeneroQuery>();
            var dtoSubstitute = Substitute.For<DGeneroDto>();
            querySubstitute.Find(dtoSubstitute)
                .ReturnsNull();
        }

        [Fact]
        public void DeleteOk()
        {
            var querySubstitute = Substitute.For<IDGeneroQuery>();
            var dtoSubstitute = Substitute.For<DGeneroDto>();
            dtoSubstitute.Id = 1;
            querySubstitute.Delete(dtoSubstitute)
                .Returns(1);
        }

        [Fact]
        public void DeleteErrorSinParametro()
        {
            var querySubstitute = Substitute.For<IDGeneroQuery>();
            var dtoSubstitute = Substitute.For<DGeneroDto>();
            querySubstitute.Delete(dtoSubstitute)
                .Returns(0);
        }

        [Fact]
        public void DeleteErrorIdNoExiste()
        {
            var querySubstitute = Substitute.For<IDGeneroQuery>();
            var dtoSubstitute = Substitute.For<DGeneroDto>();
            dtoSubstitute.Id = 3;
            querySubstitute.Delete(dtoSubstitute)
                .Returns(0);
        }

        [Fact]
        public void InsertOk()
        {
            var querySubstitute = Substitute.For<IDGeneroQuery>();
            var dtoSubstitute = Substitute.For<DGeneroDto>();
            dtoSubstitute.Id = 2;
            dtoSubstitute.Nombre = "PLATAFORMAS";
            querySubstitute.Insert(dtoSubstitute)
                .Returns(2);
        }

        [Fact]
        public void InsertErrorSinNombre()
        {
            var querySubstitute = Substitute.For<IDGeneroQuery>();
            var dtoSubstitute = Substitute.For<DGeneroDto>();
            dtoSubstitute.Id = 3;
            querySubstitute.Insert(dtoSubstitute)
                .Returns(0);
        }

        [Fact]
        public void InsertErrorMismoId()
        {
            var querySubstitute = Substitute.For<IDGeneroQuery>();
            var dtoSubstitute = Substitute.For<DGeneroDto>();
            dtoSubstitute.Id = 1;
            dtoSubstitute.Nombre = "PLATAFORMAS";
            querySubstitute.Insert(dtoSubstitute)
                .Returns(0);
        }

        [Fact]
        public void ListOk()
        {
            var querySubstitute = Substitute.For<IDGeneroQuery>();
            var dtoSubstitute = Substitute.For<DGeneroDto>();
            querySubstitute.List(dtoSubstitute)
                .Returns(new List<DGeneroDto>());
        }

        [Fact]
        public void UpdateOk()
        {
            var querySubstitute = Substitute.For<IDGeneroQuery>();
            var dtoSubstitute = Substitute.For<DGeneroDto>();
            dtoSubstitute.Id = 1;
            dtoSubstitute.Nombre = "MORPG";
            querySubstitute.Update(dtoSubstitute)
                .Returns(1);
        }

        [Fact]
        public void UpdateErrorSinNombre()
        {
            var querySubstitute = Substitute.For<IDGeneroQuery>();
            var dtoSubstitute = Substitute.For<DGeneroDto>();
            dtoSubstitute.Id = 1;
            querySubstitute.Update(dtoSubstitute)
                .Returns(0);
        }
    }
}
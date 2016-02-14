using System.Collections.Generic;
using Domain_Layer.Dtos;
using Domain_Layer.Queries;
using NSubstitute;
using NSubstitute.ReturnsExtensions;
using Xunit;

namespace Domain_Layer_Test
{
    public class TestDUsuarioQuery
    {
        [Fact]
        public void FindOk()
        {
            var querySubstitute = Substitute.For<IDUsuarioQuery>();
            var dtoSubstitute = Substitute.For<DUsuarioDto>();
            dtoSubstitute.Id = 1;
            querySubstitute.Find(dtoSubstitute)
                .Returns(new DUsuarioDto { Id = 1,
                                           Username = "dlopez",
                                           Password = "123456",
                                           EstaActivo = true});
        }

        [Fact]
        public void FindErrorSinParametro()
        {
            var querySubstitute = Substitute.For<IDUsuarioQuery>();
            var dtoSubstitute = Substitute.For<DUsuarioDto>();
            querySubstitute.Find(dtoSubstitute)
                .ReturnsNull();
        }

        [Fact]
        public void DeleteOk()
        {
            var querySubstitute = Substitute.For<IDUsuarioQuery>();
            var dtoSubstitute = Substitute.For<DUsuarioDto>();
            dtoSubstitute.Id = 1;
            querySubstitute.Delete(dtoSubstitute)
                .Returns(1);
        }

        [Fact]
        public void DeleteErrorSinParametro()
        {
            var querySubstitute = Substitute.For<IDUsuarioQuery>();
            var dtoSubstitute = Substitute.For<DUsuarioDto>();
            querySubstitute.Delete(dtoSubstitute)
                .Returns(0);
        }

        [Fact]
        public void DeleteErrorIdNoExiste()
        {
            var querySubstitute = Substitute.For<IDUsuarioQuery>();
            var dtoSubstitute = Substitute.For<DUsuarioDto>();
            dtoSubstitute.Id = 3;
            querySubstitute.Delete(dtoSubstitute)
                .Returns(0);
        }

        [Fact]
        public void InsertOk()
        {
            var querySubstitute = Substitute.For<IDUsuarioQuery>();
            var dtoSubstitute = Substitute.For<DUsuarioDto>();
            dtoSubstitute.Id = 2;
            querySubstitute.Insert(dtoSubstitute)
                .Returns(2);
        }

        [Fact]
        public void InsertErrorSinNombre()
        {
            var querySubstitute = Substitute.For<IDUsuarioQuery>();
            var dtoSubstitute = Substitute.For<DUsuarioDto>();
            dtoSubstitute.Id = 3;
            querySubstitute.Insert(dtoSubstitute)
                .Returns(0);
        }

        [Fact]
        public void InsertErrorMismoId()
        {
            var querySubstitute = Substitute.For<IDUsuarioQuery>();
            var dtoSubstitute = Substitute.For<DUsuarioDto>();
            dtoSubstitute.Id = 1;
            querySubstitute.Insert(dtoSubstitute)
                .Returns(0);
        }

        [Fact]
        public void ListOk()
        {
            var querySubstitute = Substitute.For<IDUsuarioQuery>();
            var dtoSubstitute = Substitute.For<DUsuarioDto>();
            querySubstitute.List(dtoSubstitute)
                .Returns(new List<DUsuarioDto>());
        }

        [Fact]
        public void UpdateOk()
        {
            var querySubstitute = Substitute.For<IDUsuarioQuery>();
            var dtoSubstitute = Substitute.For<DUsuarioDto>();
            dtoSubstitute.Id = 1;
            querySubstitute.Update(dtoSubstitute)
                .Returns(1);
        }

        [Fact]
        public void UpdateErrorSinNombre()
        {
            var querySubstitute = Substitute.For<IDUsuarioQuery>();
            var dtoSubstitute = Substitute.For<DUsuarioDto>();
            dtoSubstitute.Id = 1;
            querySubstitute.Update(dtoSubstitute)
                .Returns(0);
        }
    }
}
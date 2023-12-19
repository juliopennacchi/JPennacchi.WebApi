using FluentValidation;
using FluentValidation.Results;
using JPennacchi.Application.RequestReponse.Documento;
using JPennacchi.Application.Services.Implementations;
using JPennacchi.Application.Validators;
using JPennacchi.Domain.Entities;
using JPennacchi.Infra.Repository.Repositories.Interfaces;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JPennacchi.Application.Test.Serives
{
    public class DocumentoServiceTest
    {
        private IValidator<ObterDocumentoRequest> validator;


        [SetUp]
        public void Setup()
        {
            validator = new ObterDocumentoValidator();
        }

        ///ObterDocumento
        ///cenarios de testes
        /// 1. Request invalida
        /// 2. Sucesso - retorno objeto documento
        /// 3. NotFound - documento nao encontrado
        /// 4. Erro - exception no repositorio
        /// 

        [Test]
        public async Task ObterDocumento_RequestInvalida()
        {
            //mock repo
            var mockRepositorio = new Mock<IDocumentoRepository>();
            mockRepositorio.Setup(x => x.ObterDocumentoAsync(It.IsAny<string>(), It.IsAny<TipoDocumento>())).ReturnsAsync(new Documento());

            // request
            var request = new ObterDocumentoRequest
            {
                Proprietario = "",
                TipoDocumento = null

            };


            // Service que iremos testar
            var service = new DocumentoService(validator, mockRepositorio.Object);
            var response = await service.ObterDocumentoAsync(request);

            // result
            Assert.Multiple(() =>
            {
                Assert.That(response.Valid, Is.False);
                Assert.That(response.Error, Is.Not.Null);
                Assert.That(response.Documento, Is.Null);
            });
        }
    }
}

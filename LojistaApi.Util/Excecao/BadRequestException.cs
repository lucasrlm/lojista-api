using System;

namespace LojistaApi.Util.Excecao
{
    public class BadRequestException : Exception
    {
        public BadRequestException(string erro) : base(erro) { }
    }
}

using LojistaApi.Util.Excecao;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System.Net;

namespace LojistaApi.Util
{
    public class FiltroExcecaoHttp : IExceptionFilter
    {
        public void OnException(ExceptionContext context)
        {
            if (context.Exception is BadRequestException)
                context.HttpContext.Response.StatusCode = (int)HttpStatusCode.BadRequest;

            else
            {
                context.HttpContext.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
            }

            var errorDetails = new ErrorDetails()
            {
                StatusCode = context.HttpContext.Response.StatusCode,
                Message = context.Exception.Message ?? Constantes.ERRO_NAO_TRATADO
            };

            context.Result = new ObjectResult(errorDetails);
            context.ExceptionHandled = true;
        }
    }
}

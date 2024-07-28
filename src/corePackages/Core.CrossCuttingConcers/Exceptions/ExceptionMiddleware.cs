using FluentValidation;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using Newtonsoft.Json;

namespace Core.CrossCuttingConcerns.Exceptions;

public class ExceptionMiddleware
{
    private readonly RequestDelegate _next;

    public ExceptionMiddleware(RequestDelegate next)
    {
        _next = next;
    }

    public async Task Invoke(HttpContext context)
    {
        try
        {
            await _next(context);
        }
        catch (Exception exception)
        {
            await HandleExceptionAsync(context, exception);
        }
    }

    private Task HandleExceptionAsync(HttpContext context, Exception exception)
    {
        context.Response.ContentType = "application/json";

        if (exception is ValidationException validationException)
        {
            context.Response.StatusCode = (int)HttpStatusCode.BadRequest;
            object errors = validationException.Errors;

            var validationProblemDetails = new ValidationProblemDetails
            {
                Status = StatusCodes.Status400BadRequest,
                Type = "https://example.com/probs/validation",
                Title = "Validation error(s)",
                Detail = "One or more validation errors occurred.",
                Instance = context.Request.Path,
                Errors = errors
            };

            string json = JsonConvert.SerializeObject(validationProblemDetails);
            return context.Response.WriteAsync(json);
        }

        if (exception is BusinessException)
        {
            context.Response.StatusCode = (int)HttpStatusCode.BadRequest;

            var businessProblemDetails = new BusinessProblemDetails
            {
                Status = StatusCodes.Status400BadRequest,
                Type = "https://example.com/probs/business",
                Title = "Business exception",
                Detail = exception.Message,
                Instance = context.Request.Path
            };

            string json = JsonConvert.SerializeObject(businessProblemDetails);
            return context.Response.WriteAsync(json);
        }

        if (exception is EntityNotFoundException)
        {
            context.Response.StatusCode = (int)HttpStatusCode.NotFound;

            var entityNotFoundProblemDetails = new EntityNotFoundProblemDetails
            {
                Status = StatusCodes.Status404NotFound,
                Type = "https://example.com/probs/notFound",
                Title = "Entity not found exception",
                Detail = exception.Message,
                Instance = context.Request.Path
            };

            string json = JsonConvert.SerializeObject(entityNotFoundProblemDetails);
            return context.Response.WriteAsync(json);
        }

        if (exception is AuthorizationException)
        {
            context.Response.StatusCode = (int)HttpStatusCode.Unauthorized;

            var authorizationProblemDetails = new AuthorizationProblemDetails
            {
                Status = StatusCodes.Status401Unauthorized,
                Type = "https://example.com/probs/authorization",
                Title = "Authorization exception",
                Detail = exception.Message,
                Instance = context.Request.Path
            };

            string json = JsonConvert.SerializeObject(authorizationProblemDetails);
            return context.Response.WriteAsync(json);
        }
        else
        {
            // For unhandled exceptions, return a generic error message
            context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;

            var problemDetails = new ProblemDetails
            {
                Status = StatusCodes.Status500InternalServerError,
                Type = "https://example.com/probs/internal",
                Title = "Internal exception",
                Detail = exception.StackTrace,
                Instance = context.Request.Path
            };

            string json = JsonConvert.SerializeObject(problemDetails);
            return context.Response.WriteAsync(json);
        }
    }
}
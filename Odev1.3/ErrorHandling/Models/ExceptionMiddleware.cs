using ErrorHandling.Models;
using System;

public class ExceptionMiddleware
{
	private readonly RequestDelegate _next;
	private readonly ILogger<ExceptionMiddleware> _logger;

	public ExceptionMiddleware(RequestDelegate next, ILogger<ExceptionMiddleware> logger)
	{
		_next = next;
		_logger = logger;
	}

	public async Task InvokeAsync(HttpContext context)
	{
		try
		{
			await _next(context); // Bir sonraki middleware'e geç
		}
		catch (Exception ex)
		{
			_logger.LogError(ex, ex.Message);
			await HandleExceptionAsync(context, ex);
		}
	}

	private Task HandleExceptionAsync(HttpContext context, Exception exception)
	{
		context.Response.ContentType = "application/json";

		var response = context.Response;
		var apiError = new ApiError();

		switch (exception)
		{
			case UnauthorizedAccessException:
				response.StatusCode = StatusCodes.Status401Unauthorized;
				apiError.StatusCode = response.StatusCode;
				apiError.Message = ErrorMessages.Unauthorized;
				break;

			case KeyNotFoundException:
				response.StatusCode = StatusCodes.Status404NotFound;
				apiError.StatusCode = response.StatusCode;
				apiError.Message = ErrorMessages.NotFound;
				break;

			default:
				response.StatusCode = StatusCodes.Status500InternalServerError;
				apiError.StatusCode = response.StatusCode;
				apiError.Message = ErrorMessages.InternalServerError;
				apiError.Details = exception.Message; // Sadece development için
				break;
		}

		return context.Response.WriteAsJsonAsync(apiError);
	}
}


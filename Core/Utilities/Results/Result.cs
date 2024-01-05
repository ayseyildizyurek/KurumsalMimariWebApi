namespace Core.Utilities.Results
{
	public class Result : IResult
	{
        public Result(bool success, string message):this(success) //her ikiside gönderilirse mesajı set eder daha sonra this succes olan ctor gider succesi de set eder ama her ikisi de gönderilmediğinde sadece success gönderildiğinde mesajı set etmez.
        {
            Message = message;
        }

        public Result(bool success)
        {
            Success = success;
        }
        public bool Success { get; }
		public string Message { get; }
	}
}

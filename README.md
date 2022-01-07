# awslog4net-example
Run as a web application in IIS
The web application hangs and no aws log file is created (<LibraryLogFileName>c:\temp\logs\tmp\my_app_awslog.txt</LibraryLogFileName>).

If downgrading to a version of AWSSDK.Core < 3.7.1 the application start up as expected and a lot of errors is logged to 'c:\temp\logs\tmp\my_app_awslog.txt' which is fine since I got invalid credentials on my machine.

Example of error message logged:

Log Entry : 
1/7/2022 10:51:07 AM
  :
  :Amazon.CloudWatchLogs.AmazonCloudWatchLogsException: The security token included in the request is invalid ---> Amazon.Runtime.Internal.HttpErrorResponseException: The remote server returned an error: (400) Bad Request. ---> System.Net.WebException: The remote server returned an error: (400) Bad Request.
   at System.Net.HttpWebRequest.EndGetResponse(IAsyncResult asyncResult)
   at System.Threading.Tasks.TaskFactory`1.FromAsyncCoreLogic(IAsyncResult iar, Func`2 endFunction, Action`1 endAction, Task`1 promise, Boolean requiresSynchronization)
--- End of stack trace from previous location where exception was thrown ---
   at System.Runtime.ExceptionServices.ExceptionDispatchInfo.Throw()
   at System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(Task task)
   at Amazon.Runtime.Internal.HttpRequest.<GetResponseAsync>d__19.MoveNext() in D:\JenkinsWorkspaces\trebuchet-stage-release\AWSDotNetPublic\sdk\src\Core\Amazon.Runtime\Pipeline\HttpHandler\_bcl\HttpWebRequestFactory.cs:line 395
   --- End of inner exception stack trace ---
   at Amazon.Runtime.Internal.HttpRequest.<GetResponseAsync>d__19.MoveNext() in D:\JenkinsWorkspaces\trebuchet-stage-release\AWSDotNetPublic\sdk\src\Core\Amazon.Runtime\Pipeline\HttpHandler\_bcl\HttpWebRequestFactory.cs:line 421
--- End of stack trace from previous location where exception was thrown ---
   at System.Runtime.ExceptionServices.ExceptionDispatchInfo.Throw()
   at System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(Task task)
   at Amazon.Runtime.Internal.HttpHandler`1.<InvokeAsync>d__9`1.MoveNext() in D:\JenkinsWorkspaces\trebuchet-stage-release\AWSDotNetPublic\sdk\src\Core\Amazon.Runtime\Pipeline\HttpHandler\HttpHandler.cs:line 183
--- End of stack trace from previous location where exception was thrown ---
   at System.Runtime.ExceptionServices.ExceptionDispatchInfo.Throw()
   at System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(Task task)
   at Amazon.Runtime.Internal.Unmarshaller.<InvokeAsync>d__3`1.MoveNext()
--- End of stack trace from previous location where exception was thrown ---
   at System.Runtime.ExceptionServices.ExceptionDispatchInfo.Throw()
   at System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(Task task)
   at Amazon.Runtime.Internal.ErrorHandler.<InvokeAsync>d__5`1.MoveNext()
   --- End of inner exception stack trace ---
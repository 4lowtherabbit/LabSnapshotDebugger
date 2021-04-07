# Lab to demo snapshot debugger
This lab can be used to repro an unhandled exception 500 error, which can be trouleshot by following the steps in https://docs.microsoft.com/en-us/azure/azure-monitor/app/asp-net-exceptions

Repro steps:
1. Browse /repro/ThrowException to repro an 500 response, which is caused by an unhandled exception.

    Use Snaptshot debugger to troubleshoot it.

1. Browse /reprp/Return500 to repro a 500 response, without any exception thrown.

    Can Snapshot debugger provide any detail of this 500 error?

[![Deploy to Azure](http://azuredeploy.net/deploybutton.png)](https://portal.azure.com/#create/Microsoft.Template/uri/https%3A%2F%2Fraw.githubusercontent.com%2F4lowtherabbit%2FLabSnapshotDebugger%2Fmaster%2Fazuredeploy.json){:target="_blank"}

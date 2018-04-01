# REST and SOAP WS lab

The main idea of this lab is to develop and deploy an intermediary Web Service (IWS) between the [Velib WS](https://developer.jcdecaux.com/#/home) and some WS clients.

## How to open it
First of all, open Visual Studio as Administrator if it's not set by default. Open the file IWS_Soap.sln with. Do a Right-click on "Solution 'IWS_Soap'" in the Solution Explorator, then click on Properties. Select the projects you want to run. You must run IWS_Soap, with whatever client you want to test. Then, validate your choice and launch the project.

## Extensions done
- MVP (IWS + Console Client)
 - GUI Client
 -  Cache in IWS
 - Monitoring

## Minimal Viable Product
### Intermediary Web Service
The main service's interface is IService1.cs. 

```c#
        Contract[] GetCities();
        Station[] GetStationsByCity(string city);
        Station GetInfoByStation(string name, string city);
        void RefreshCache(string city);
```
### Console Client
Commands available : 
- "help" : displays the commands you can write;
- "consult" : allows you to see the information about a station you want;
- "exit" : shuts down the program. 

## GUI Client
![Screenshot of the Client GUI](http://image.noelshack.com/fichiers/2018/13/7/1522612121-gui-client.png)

## Monitor
### Monitor Service
```c#
        int GetRequestNumber();
        int GetCacheRequestNumber();
        string[] GetCacheContent();
```
- GetRequestNumber() : returns the number of the request made from the IWS to the VelibWS;
- GetCacheRequestNumber() : returns the number of request made to the cache;
- GetCacheContent() : returns an array of string with the name of every city saved in the cache.

### Monitor GUI
It allows you to see the content of the cache and the number of request made by the client. 

![Screenshot of the Monitoring GUI](http://image.noelshack.com/fichiers/2018/13/7/1522612424-gui-monitor.png)

## Cache
In order to improve the speed of the answers and reduce the number of call to the VelibWS, the informations of a city (its stations, and theirs informations) are kept in cache for 10 seconds.

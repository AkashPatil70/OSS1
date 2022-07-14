var http = require("http");
var url = require("url");
var fs = require('fs');

var server=http.createServer(function(req, res){

var p=url.parse(req.url,true).pathname;
if(p!='/favicon.ico')
{
     var cdate=new Date();
     var str="Request received for "+p+" at time"+cdate.toString();
 
    fs.appendFile("mylog.txt", str, function(error){
    
         if(!error)
       {
	     console.log("request is logged in log file.");	
         res.write("request has been made");
         res.end();
         }
    });
}
});
		

server.listen(9000,function(){console.log("server at 9000") });
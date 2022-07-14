var http = require('http');
var url = require('url');
var fs = require('fs');

var server = http.createServer(function(req,res){
	var url_p = url.parse(req.url,true);

	fs.readFile("cnt.txt", function(err, data){
		if(!err)
		{
			
                    var n = parseInt(data.toString());
                    n++;
			 fs.writeFile("cnt.txt",""+n, function(err){
                          if(!err)
                               console.log("Count updated");
	
				});	
                    res.writeHead(200, { 'content-type': 'text/html' });
		      res.write("Visit count : "+n)
			res.end();
		}
	});	

});

server.listen(9000,function(){console.log("server at 9000") });
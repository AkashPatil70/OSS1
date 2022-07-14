var exp = require('express');
var app = exp();

app.get('/home',function(req,res){
	res.send("<h1> Hello  </h1>");
});

app.get('/login',function(req,res){
       res.sendFile(__dirname+"/welcome.html");
});

app.get('/welcome',function(req,res){
	res.send("<h1>Welcome user</h1>");
});

app.all('*',function(req,res){
	res.send("<h1>Invalid URL !!!......</h1>");
});

app.listen(9000,function(){
	console.log("server started at 9000");	
});

var exp = require('express');
var app = exp();

//route handler for another html file
app.get('/greet',function(req,res){
       res.sendFile(__dirname+"/welcome.html");
});

//route handler for simple request

app.get('/welcome',function(req,res){
	res.send("<h1>Welcome to web app</h1>");
});

app.listen(9000,function(){
	console.log("exp server started at 9000");	
});



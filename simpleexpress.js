var exp = require('express');

var app = exp();

//route handler for /hello request
app.get('/home',function(req,res){
	res.send("<h1> Hello from express </h1>");
});

app.get('/login',function(req,res){
       res.sendFile(__dirname+"/login.html");
});

app.get('/logincheck',function(req,res){
	if(req.query.uid=="bakul" && req.query.pwd=="bakul123")
		res.send("Login successful");
	else
		res.send("Failed Login");	
});

app.all('*',function(req,res){
	res.send("Invalid URL !!");
});

app.listen(9000,function(){
	console.log("exp server started at 9000");	
});



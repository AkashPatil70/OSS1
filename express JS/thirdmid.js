var exp=require('express');
var app=exp();
var bp = require('body-parser');
app.use(bp.urlencoded({extended: false}));

app.get('/login',function(req,res){
       res.sendFile(__dirname+"/logins.html");
});


app.post('/logincheck',function(req,res){
	

	if(req.body.nm == "object" && req.body.pwd == "knowit")
	{
		res.writeHead(200,{'content-type':'text/html'});
		res.write("<h2> Successful </h2>");
		res.end();
	}
	else
		res.redirect('/login');
});


app.all('*',function(req,res){
	res.send("Invalid URL !!!");
});

app.listen(9000,function(){
	console.log("exp app started");
});

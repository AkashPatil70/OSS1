var exp = require('express');
var app = exp();

//route handler for another html file
app.get('/web',function(req,res){
       res.sendFile(__dirname+"/login.html");
});

//route handler for simple request

app.get('/knowit',function(req,res){
 
    if(req.query.nm=="object" && req.query.pwd=="knowit")
       res.send("Successful Login");
  else
     res.send("Login Failed");

	
});

app.listen(9500,function(){
	console.log("exp server started at 9500");	
});



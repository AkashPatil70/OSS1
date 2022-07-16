var exp = require('express');
var app = exp();
app.use(exp.static('images'));

//route handler for another html file
app.get('/web',function(req,res){
       res.sendFile(__dirname+"/loginwbg.html");
});

//route handler for simple request

app.get('/knowit',function(req,res){
 
    if(req.query.nm=="object" && req.query.pwd=="knowit")
       res.send("Successful Login");
  else
     res.send("Login Failed");

	
});

app.listen(9000,function(){
	console.log("exp server started at 9000");	
});



var exp = require('express');
var app = exp();
var fs = require('fs');

//general
app.use(function(req,res,next){
	console.log(req.url+ " in general middleware");

    if(req.url!='/favicon.ico')
    {
     var cdate=new Date();
     var str="Request received for "+req.url+" at time"+cdate.toString()+"\n";
     fs.appendFile("mylogware.txt", str, function(error){
    
         if(!error)
          {
	     console.log("request is logged in log file.");	
        
         }
                                                        })
      }
           next();
});

app.get('/login',function(req,res){

	 res.write("request has been made");
         res.end();
})


app.listen(9000,function(){
	console.log("exp app started");
});

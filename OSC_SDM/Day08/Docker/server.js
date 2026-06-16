const express = require("express");
const app = express();
const os = require('os');

app.get('/',(req,res)=>{
    res.send("Hello From Express!")
})

app.get("/health",(req,res)=>{
    res.json({
        "status": "okay",
        "hostname": os.hostname(),
        "machine": os.machine(),
        "platform": os.platform(),
        "memory": os.freemem() + " free out of " + os.totalmem()
    })
})

app.get("/products",(req,res)=>{
    res.json([
        {id: 1, name: 'iPhone17', price: 90000.0},
        {id: 2, name: 'Mac Book Pro', price: 180000.0},
    ])
})

app.listen(4000,(req,res) =>{
    console.log("Server started at port 4000")
})
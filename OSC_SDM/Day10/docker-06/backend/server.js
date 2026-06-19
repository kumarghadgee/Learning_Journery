const express = require("express")
const cors = require("cors")
const mysql = require("mysql2/promise")
const os = require("os")

const PORT = process.env.PORT || 3000
const app = express()

app.use(cors())
app.use(express.json())

app.get("/", (req, res) => {
    res.status(200).json({
        status: "success",
        message: "Hello, World!"
    })
})

app.get("/health", (req, res) => {
    res.status(200).json({
        status: "success",
        timestamp: new Date().toISOString(),
        hostname: os.hostname(),
        platform: os.platform(),
        memoryUsage: process.memoryUsage(),
        nodeVersion: process.version
    })
})

app.get("/products", async (req, res) => {
    try {
        const con = await mysql.createConnection({
            host: process.env.DB_HOST,
            user: process.env.DB_USER,
            password: process.env.DB_PASSWORD,
            database: process.env.DB_NAME,
        })

        const [rows] = await con.execute("SELECT * FROM products");

        await con.end();

        res.status(200).json({
            status: "success",
            result: rows            
        })
    }
    catch(err) {
        console.log(err)
        res.status(500).json({
            status: "error",
            message: `${err.name}: ${err.message}`
        })
    }
})

app.listen(PORT, () => {
    console.log(`express server ready at port ${PORT}.`)
})

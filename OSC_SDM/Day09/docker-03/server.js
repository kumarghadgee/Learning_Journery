const express = require("express");
const multer = require("multer");
const path = require("path");
const fs = require("fs");

const app = express();
const PORT = process.env.PORT || 3000;

// serve static files
app.use(express.static("public"));

// configure upload storage
const upload = multer({ dest: "uploads/" });

// upload file
app.post("/upload", upload.single("file"), (req, res) => {
  if (!req.file) {
    return res.status(400).send("No file uploaded");
  }
  res.send(`
    <h2>Upload successful!</h2>
    <p>Stored as: ${req.file.filename}</p>
    <a href="/">Upload another file</a><br/>
    <a href="/gallery">View Gallery</a>
  `);
});

// gallery -- file list
app.get("/gallery", (req, res) => {
  fs.readdir("uploads", (err, files) => {
    if (err) {
      return res.status(500).json({ error: "Failed to read uploads" });
    }
    let images = `<ul>`;
    for(const file of files)
        images += `<li><a href="/images/${file}">${file}</a></li>`;
    images += `</ul>`;
    res.send(`
        <h2>Gallery</h2>
        ${images}
        <a href="/">Upload another file</a>
    `);
  });
});

// display image
app.get("/images/:filename", (req, res) => {
  const filePath = path.join(__dirname, "uploads", req.params.filename);
  // 1. Check if the file actually exists to prevent crashes
  if (!fs.existsSync(filePath)) {
    return res.status(404).send("File not found");
  }
  // 2. Explicitly force the content type and inline headers
  res.setHeader("Content-Type", "image/jpeg");
  res.setHeader("Content-Disposition", "inline");
  // 3. Stream the file directly to the browser
  res.sendFile(filePath);
});


app.listen(PORT, () => {
  console.log(`Server running on http://localhost:${PORT}`);
});
var http = require('http');

http.createServer(function (req, res) {
  res.write("ping");
  res.end();
}).listen(8080);

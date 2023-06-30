# Test Server
This repository contains a lightweight ASP.NET Core application designed to serve as a simple HTTP request dump. It captures and displays the details of an incoming HTTP request, providing useful information for debugging and testing purposes.

## Usage
The application listens for HTTP GET requests on the root path ("/"). When a request is made, the server captures the details of the request and returns a JSON response with the captured information.

### Example Request

```
HTTP/2.0 GET /
```
The above request returns a JSON object containing the following details:

```json
{
    "method": "GET",
    "scheme": "http",
    "isHttps": false,
    "host": "xxx",
    "pathBase": "",
    "path": "/",
    "protocol": "HTTP/2",
    "query": {},
    "headers": {
        "sec-ch-ua-platform": "\"Windows\"",
        "accept-encoding": "gzip",
        "traceparent": "00-3594ed5c6cec447024644cca00bcb861-082a3ddc41a61447-00",
        "sec-ch-ua": "\"Not.A/Brand\";v=\"8\", \"Chromium\";v=\"114\", \"Microsoft Edge\";v=\"114\"",
        "sec-ch-ua-mobile": "?0",
        "sec-fetch-mode": "navigate",
        "cdn-loop": "cloudflare",
        "sec-fetch-dest": "document",
        "priority": "u=0, i",
        "accept-language": "de,de-DE;q=0.9,en;q=0.8,en-GB;q=0.7,en-US;q=0.6",
        "x-forwarded-proto": "https",
        "host": "test.angelobreuer.de",
        "sec-fetch-site": "none",
        "user-agent": "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/114.0.0.0 Safari/537.36 Edg/114.0.1823.58",
        "accept": "text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,image/apng,*/*;q=0.8,application/signed-exchange;v=b3;q=0.7",
        "sec-fetch-user": "?1"
    }
}
```

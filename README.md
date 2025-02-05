
# Classify Number API

This API classifies numbers based on their mathematical properties and provides fun facts. It checks whether a number is prime, perfect, Armstrong, odd, and calculates the sum of its digits. The API also provides a fun fact about the number.

## Technology Stack

- **Programming Language**: C# (.NET 9)
- **Framework**: ASP.NET Core
- **Response Format**: JSON
- **Deployment**: Heroku (or any other platform of your choice)
- **Version Control**: GitHub

## API Endpoint

### **GET** `/api/classify-number?number={number}`

- **Query Parameters**:
  - `number`: The number to classify (must be a valid integer).
  
- **Response Format (200 OK)**:
  ```json
  {
      "number": 371,
      "is_prime": false,
      "is_perfect": false,
      "properties": ["armstrong", "odd"],
      "digit_sum": 11,
      "fun_fact": "371 is an Armstrong number because 3^3 + 7^3 + 1^3 = 371"
  }
  ```

- **Response Format (400 Bad Request)**:
  ```json
  {
      "number": "alphabet",
      "error": true
  }
  ```

## Features

- **Prime Check**: Determines whether the number is prime.
- **Perfect Number Check**: Checks if the number is perfect.
- **Armstrong Number Check**: Identifies Armstrong numbers.
- **Odd/Even Check**: Identifies whether the number is odd or even.
- **Digit Sum**: Calculates the sum of the digits of the number.
- **Fun Fact**: Returns a fun fact related to the number.

## CORS

The API handles **Cross-Origin Resource Sharing (CORS)** and accepts requests from any origin for testing purposes. 

## Deployment

This API is publicly accessible and deployed on [Heroku](https://your-heroku-app-name.herokuapp.com). You can also deploy it to any other platform like Azure, AWS, or DigitalOcean.

## Running Locally

To run this project locally, follow the steps below:

1. **Clone the repository**:
   ```bash
   git clone https://github.com/your-username/number-classifier-api.git
   cd number-classifier-api
   ```

2. **Install dependencies**:
   The project uses .NET 9. Ensure you have the correct version installed.

3. **Run the application**:
   ```bash
   dotnet run
   ```

4. **Access the API**:
   The API will be available at `http://localhost:5000/api/classify-number`.

## Error Handling

- **400 Bad Request**: If the input is not a valid integer, the API will return a JSON response with an error message.
- **500 Internal Server Error**: In case of server issues, an error response will be returned.

## Testing

To test the API, you can use tools like **Postman** or **curl**. Here's an example using `curl`:

```bash
curl "http://localhost:5000/api/classify-number?number=371"
```

## License

This project is licensed under the MIT License.

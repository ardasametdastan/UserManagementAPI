# User Management API

This is a simple User Management API built with ASP.NET Core. It supports basic CRUD operations for managing users and includes middleware for logging and error handling.

## Features

- **GET**: Fetch all users or a specific user by ID.
- **POST**: Create a new user.
- **PUT**: Update an existing user.
- **DELETE**: Delete a user by ID.
- **Middleware**: Includes logging middleware to track incoming requests.
- **Validation**: Input validation is implemented for the user data.

## Prerequisites

- [.NET SDK](https://dotnet.microsoft.com/download) 6.0 or later
- A code editor such as [Visual Studio Code](https://code.visualstudio.com/) or [Visual Studio](https://visualstudio.microsoft.com/)

## Installation

1. Clone the repository to your local machine:

    ```bash
    git clone https://github.com/yourusername/UserManagementAPI.git
    cd UserManagementAPI
    ```

2. Restore the project dependencies:

    ```bash
    dotnet restore
    ```

3. Run the application:

    ```bash
    dotnet run
    ```

   This will start the API on `https://localhost:5001` by default.

## API Endpoints

### 1. Get All Users

**GET** `/api/user`

Returns a list of all users.

**Response:**
```json
[
    {
        "id": 1,
        "name": "John Doe",
        "email": "john.doe@example.com"
    },
    {
        "id": 2,
        "name": "Jane Smith",
        "email": "jane.smith@example.com"
    }
]
```

### 2. Get User By ID

**GET** `/api/user/{id}`

Returns the details of a user by their ID.

**Response:**
```json
{
    "id": 1,
    "name": "John Doe",
    "email": "john.doe@example.com"
}
```

### 3. Create New User

**POST** `/api/user`

Creates a new user.

**Request Body:**
```json
{
    "name": "New User",
    "email": "new.user@example.com"
}
```

**Response:**
```json
{
    "id": 3,
    "name": "New User",
    "email": "new.user@example.com"
}
```

### 4. Update User

**PUT** `/api/user/{id}`

Updates an existing user.

**Request Body:**
```json
{
    "name": "Updated Name",
    "email": "updated.email@example.com"
}
```

**Response:**
```json
{
    "id": 1,
    "name": "Updated Name",
    "email": "updated.email@example.com"
}
```

### 5. Delete User

**DELETE** `/api/user/{id}`

Deletes a user by their ID.

**Response:**
```json
{
    "message": "User deleted successfully"
}
```

## Middleware

### Logging Middleware

The API includes a custom logging middleware that logs each incoming HTTP request with the request method, path, and timestamp.

### Error Handling Middleware

The application uses exception handling middleware to catch and handle unexpected errors. In case of an error, a user-friendly message is returned without exposing sensitive information.

## Validation

Input validation is performed when creating or updating a user. If invalid data is sent in the request, a `400 Bad Request` response is returned with the validation error details.

## Running Tests

If you want to run tests, you can do so using the following command:

```bash
dotnet test
```

## Contribution

Feel free to open issues or create pull requests. If you would like to contribute to this project, you can fork the repository and submit a pull request with your improvements.

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.

---

### Created by [Your Name](https://github.com/yourusername)
```

### Açıklamalar:
- **Proje Başlığı ve Kısa Tanıtım**: Projenin ne olduğunu açıklayan bir giriş.
- **Özellikler**: API'nin hangi işlemleri desteklediği, middleware, doğrulama vb. özellikler hakkında bilgi.
- **Kurulum Adımları**: Projeyi yerel ortamda çalıştırabilmek için gereken adımlar.
- **API Uç Noktaları**: Her bir API uç noktasının ne yaptığı, örnek istek ve yanıtlar.
- **Middleware ve Hata Yönetimi**: Özelleştirilmiş middleware hakkında bilgi.
- **Testler**: Testleri çalıştırma komutları.
- **Katkı**: Diğerlerinin projeye nasıl katkıda bulunabileceği.
- **Lisans**: Projenin lisansı hakkında bilgi.

### GitHub'a Yüklemeden Önce:
- GitHub repo linkinizi doğru şekilde yazdığınızdan emin olun.
- README.md dosyasını proje dizininde tutarak, GitHub üzerinde projenizle birlikte görüntülenmesini sağlayabilirsiniz.

Umarım bu örnek, projeniz için bir başlangıç olur! Yardıma ihtiyacınız olursa tekrar bana yazabilirsiniz.

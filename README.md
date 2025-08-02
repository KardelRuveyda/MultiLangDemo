# 🌍 MultiLangDemo - ASP.NET Core Localization Example

MultiLangDemo is a sample ASP.NET Core MVC project that demonstrates how to implement **multi-language support** using `IStringLocalizer` and `IViewLocalizer`.

Users can view the site in their preferred language based on browser settings or a query string.

---

## 📁 Project Structure

```
MultiLangDemo/
├── Controllers/
│   └── HomeController.cs
├── Views/
│   └── Home/
│       └── Index.cshtml
├── Resources/
│   └── Views/
│       └── Home/
│           ├── Index.en-US.resx
│           ├── Index.tr-TR.resx
│           └── Index.de-DE.resx
├── Program.cs
├── MultiLangDemo.csproj
└── README.md
```

---

## 🚀 Getting Started

### ✅ Requirements

- [.NET 9 SDK](https://dotnet.microsoft.com/download)
- Visual Studio Code or Visual Studio 2022+
- Git (optional)

### 🔧 Setup Instructions

```bash
git clone https://github.com/yourusername/MultiLangDemo.git
cd MultiLangDemo
dotnet restore
dotnet run
```

The application will launch at:  
👉 https://localhost:5001

---

## 🌐 Testing Localization

You can switch the UI language by appending `?ui-culture=xx-XX` to the URL:

| Language | URL Example                                      |
|----------|--------------------------------------------------|
| 🇺🇸 English | `https://localhost:5001/?ui-culture=en-US`       |
| 🇹🇷 Turkish | `https://localhost:5001/?ui-culture=tr-TR`       |
| 🇩🇪 German  | `https://localhost:5001/?ui-culture=de-DE`       |

---

## 🧩 Key Concepts

- `IViewLocalizer`: Used in Razor Views to localize UI content.
- `IStringLocalizer<T>`: Used in controllers or services to retrieve localized strings.
- `.resx` Files: Resource files that store key-value pairs for each supported culture.

---

## 💡 Sample Output

When visiting `https://localhost:5001/?ui-culture=tr-TR`:

```
Hoş geldiniz!
Aktif dil: tr-TR
```

When visiting `https://localhost:5001/?ui-culture=en-US`:

```
Welcome to our site!
Active culture: en-US
```

---

## ➕ Adding a New Language

To add support for French:

1. Create a new resource file:  
   `Resources/Views/Home/Index.fr-FR.resx`

2. Add translation keys and values:

| Name            | Value                      |
|-----------------|----------------------------|
| WelcomeMessage  | Bienvenue sur notre site   |

3. Add `fr-FR` to the supported cultures list in `Program.cs`.

---

## 🔒 Security Note

If you encounter a warning like:

```
Package 'System.Text.RegularExpressions' 4.3.0 has a known high severity vulnerability
```

You can upgrade the package using:

```bash
dotnet add package System.Text.RegularExpressions --version 4.3.1
```

---

## 📄 License

This project is licensed under the MIT License.

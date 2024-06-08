# keycloak-dotnet
This project is mean to be an example of how to integrate the Keycloak identity provider with a .NET + React application.

## Generating certificates for Keycloak
Run the following commands:

```
openssl req -newkey rsa:2048 -nodes -keyout keycloak.key.pem -x509 -days 3650 -out keycloak.crt.pem
chmod 755 keycloak.key.pem
mv keycloak.* certs/
```

The `certs` folder is excluded from the repository.


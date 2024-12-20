﻿# codelsoft-api-gateway
#### Este microservicio usa el puerto **5000**, necesitas tenerlo habitado para usar este microservicio (localhost:5000)
## Requisitos previos (por confirmar)

- SDK [.NET8](https://dotnet.microsoft.com/es-es/download/dotnet/8.0).
- EF CLI [EF CLI](https://www.nuget.org/packages/dotnet-ef/).
- Git [2.33.0](https://git-scm.com/downloads) o superior.

#### Este proyecto consta de migrar un monolito a 3 microservicios, donde está API Gateway va a “unir” estos, por lo que primeramente deberemos de clonar los 4 repositorios con los que funcionara la API Gateway (el monolito, auth-service, career-service, user-service), los pasos de la instalación de cada uno estará en el respectivo repositorio.

- [Cubi12 monolito (branch taller2)](https://github.com/Dizkm8/cubi12-api.git)
- [codelsoft-auth-service](https://github.com/KuajinaiSS/codelsoft-auth-service.git)
- [codelsoft-career-service](https://github.com/KuajinaiSS/codelsoft-career-service.git)
- [codelsoft-user-service](https://github.com/funktasthic/CodelsoftUserService.git)

## Pasos para clonar

1. Clona el repositorio:
```bash
git clone https://github.com/KuajinaiSS/codelsoft-api-gateway.git
```

2. Acederemos a la carpeta:
```bash
cd codelsoft-api-gateway
```

3. Accederemos con nuestro editor de codigo/ide preferido

4. En el terminal, instalaremos las dependendencias
```bash
dotnet restore
```

4. Ejecutarmeos el contenedor de Docker para instalar RabbitMQ
```bash
docker-compose up -d
```
Una vez levantado el contenedor, acceder a RabbitMQ con http://localhost:15672/ y las credenciales 
Username:guest
Password:guest

5. Ejecutamos el proyecto
```bash
dotnet run
```

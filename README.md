
# Comercio Electrónico

Aplicación de comercio electrónico utilizando arquitectura de microservicios.

## Tecnologías Utilizadas

El proyecto se construye utilizando las siguientes tecnologías:

- **.NET 8:** La última versión del framework de desarrollo de Microsoft para la creación de aplicaciones en diversas plataformas.
- **.NET Core:** Utilizado para desarrollar APIs RESTful.
- **Entity Framework Core:** ORM utilizado para interactuar con la base de datos SQL Server.
- **Azure Service Bus:** Se utiliza para la comunicación entre los microservicios de la aplicación.
- **Ocelot API Gateway:** Proporciona una puerta de enlace API para enrutar y administrar el tráfico entre los microservicios.
- **.NET Identity:** Utilizado para la autenticación y autorización de usuarios en la aplicación.
- **JWT (JSON Web Tokens):** Utilizado para la autenticación y generación de tokens de acceso.
-  **Auth y Roles de .NET Core 8:** Mecanismos integrados para la gestión de autenticación y roles.

## Patrón Repository
Se implementa el patrón Repository para gestionar el acceso a los datos. Se definen interfaces y clases concretas para cada entidad de base de datos, lo que permite una separación clara entre la lógica de negocio y la lógica de acceso a datos.

## Microservicios Desarrollados

Se desarrollan los siguientes microservicios y componentes:

1. **Microservicio de Producto**
2. **Microservicio de .NET Identity**
3. **Microservicio de Cupón**
4. **Microservicio de Carrito de Compras**
5. **Microservicio de Pedido**
6. **Microservicio de Correo Electrónico**
7. **Microservicio de Pago**
8. **Proyecto de Puerta de Enlace Ocelot**

## Instrucciones de Uso

Para ejecutar la aplicación en tu entorno local, sigue estos pasos:

1. Clona el repositorio a tu máquina local.
2. Asegúrate de tener instalado .NET 8 y SQL Server en tu sistema.
3. Configura las conexiones de base de datos en los archivos de configuración de cada microservicio.
4. Ejecuta cada microservicio.

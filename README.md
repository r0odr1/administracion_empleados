# Employee Management App

Aplicación de Gestión de Empleados - Full Stack: .NET 10 (API REST) + Angular + SQLite + JWT

## Descripción

Esta aplicación permite gestionar empleados a través de una interfaz web. Incluye funcionalidades de autenticación, creación, edición, eliminación y listado de empleados.

## Prerrequisitos

Antes de comenzar, asegúrate de tener instalados los siguientes componentes:

- **.NET 10 SDK**: Descárgalo desde [dotnet.microsoft.com](https://dotnet.microsoft.com/download/dotnet/10.0)
- **Node.js 18+**: Descárgalo desde [nodejs.org](https://nodejs.org/)
- **Angular CLI**: Instálalo globalmente con `npm install -g @angular/cli`
- **Git**: Para clonar el repositorio

## Instalación

### 1. Clonar el repositorio

```bash
git clone
cd Gestion_Empleados
```

### 2. Instalar dependencias del Backend

Navega a la carpeta del backend y instala las dependencias:

```bash
cd EmployeeApi
dotnet restore
```

### 3. Instalar dependencias del Frontend

Navega a la carpeta del frontend e instala las dependencias:

```bash
cd ../front/EmployeeApp/employee-frontend
npm install
```

## Ejecución

### Ejecutar el Backend

Desde la raíz del proyecto, navega al backend y ejecuta:

```bash
cd EmployeeApi
dotnet run
```

El backend estará disponible en: https://localhost:5269

### Ejecutar el Frontend

Desde la raíz del proyecto, navega al frontend y ejecuta:

```bash
cd front/EmployeeApp/employee-frontend
ng serve
```

El frontend estará disponible en: http://localhost:4200

## Uso

1. Abre tu navegador y ve a http://localhost:4200
2. Inicia sesión con las credenciales de prueba:
   - Usuario: admin
   - Contraseña: admin123
3. Una vez autenticado, podrás:
   - Ver la lista de empleados
   - Crear nuevos empleados
   - Editar empleados existentes
   - Eliminar empleados

## Estructura del Proyecto

- `EmployeeApi/`: Backend en .NET 10 con API REST
- `front/EmployeeApp/employee-frontend/`: Frontend en Angular
- `database/`: Base de datos SQLite (se crea automáticamente al ejecutar el backend)

## Notas Adicionales

- Asegúrate de que los puertos 4200 (frontend) y 5269 (backend) estén disponibles.
- Si encuentras problemas con CORS, verifica la configuración del backend.
- Para desarrollo, puedes usar `ng serve --open` para abrir automáticamente el navegador.

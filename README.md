# IPET 250 Windows Forms

Sistema de gestión escolar desarrollado en C# y Windows Forms, que permite realizar operaciones CRUD (Crear, Leer, Actualizar, Eliminar) sobre varias tablas de una base de datos escolar.
El proyecto gestiona alumnos, ex-alumnos, docentes, no docentes y usuarios para login, ofreciendo una interfaz intuitiva.

---

## Funcionalidades principales
- **Login con validación desde la base de datos**.
- **CRUD completo para ex-alumnos**.
- **CRUD completo para docentes**.
- **CRUD completo para no docentes**.
- **CRUD completo para alumnos**.

---

## Ejemplo Login
- Nombre de usuario: **juanperez**
- Contraseña: **1234**

Si realiza la consulta `SELECT * FROM Usuario` puede ver las otras credenciales disponibles para poder ingresar al programa.

---

## Base de datos
La base de datos del proyecto está incluida en el repositorio como archivo .bak, que contiene las siguientes tablas:
- **Alumno**
- **ExAlumno**
- **Docente**
- **NoDocente**
- **Usuario**

### ¿Cómo restaurar la base de datos en SQL Server?
1. Abrir **SQL Server Management Studio (SSMS)**.
2. Conectarse al servidor.
3. Hacer clic derecho en **Bases de Datos** → **Restaurar base de datos...**
4. En la ventana de restauración:
   - Seleccionar **Dispositivo → Examinar →** elegir el archivo .bak del repositorio.
   - Escribir el nombre: *"Empleados_DB"* para la base de datos.
5. Hacer clic en **Aceptar**.
6. Una vez restaurada, se puede usar la base de datos en el proyecto.

---

## Cómo clonar el repositorio

```bash
git clone https://github.com/mateooo07/WindowsFormsIPET250.git
cd WindowsFormsIPET250
```
---
##  Contacto

Creado por **Mateo Pavoni**  
[mateopavoni6@gmail.com]   

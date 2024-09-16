## Contexto del Proyecto

### Descripción General 
El proyecto fue desarrollado para colectar y analizar datos de ventas, utilizando Microsoft SQL Server y sus herramientas de análisis, integración y reporte.

### Propósito 
Mejorar la toma de decisiones estratégicas mediante el análisis detallado de las ventas, desglosadas en dimensiones clave: Clientes, Productos y Geografía.

### Estado Actual 
El sistema está en funcionamiento desde hace varios años y sigue proporcionando valor a la organización.

## Objetivos del Proyecto

### Centralización de los Datos de Ventas 
Consolidar los datos de diversas fuentes operacionales en un sistema de DataMart.
Mejora del Análisis de Datos 
Implementar análisis multidimensional para identificar patrones de ventas en función de clientes, productos y regiones geográficas.

### Automatización de Procesos 
Crear un flujo automatizado de datos para garantizar la actualización continua del sistema de reportes y análisis.

## Requerimientos Funcionales
### Dimensiones a Analizar:

**Clientes**: Información relevante de los clientes, como identificación, segmentación y tipo de cliente.
**Productos**: Detalles del catálogo de productos, sus categorías y precios.
**Geografía**: Ubicaciones de las ventas organizadas en una jerarquía (País, Región, Ciudad).

**Hechos de Ventas**:
Métricas como ingresos, cantidad vendida, costos, márgenes, etc., organizados en la tabla de hechos de ventas.

**DataMart de Ventas:**
Estructura de DataMart basada en un esquema estrella, con las dimensiones mencionadas y la tabla de hechos de ventas.

**Flujo de Datos (ETL):**
Proceso de extracción, transformación y carga mediante SSIS, con una etapa intermedia en Sales Staging para limpiar y transformar los datos antes de cargarlos en el DataMart.

**Análisis Multidimensional:**
Uso de SSAS para crear cubos OLAP y realizar análisis desde diferentes perspectivas de las dimensiones definidas.

**Generación de Informes:**
Informes interactivos y visuales generados en SSRS para mostrar las ventas por cliente, producto y geografía.

## Requerimientos No Funcionales
**Rendimiento**: Optimización de los tiempos de carga y consulta de los datos.
Disponibilidad: El sistema debe estar disponible 24/7 para consulta y generación de informes.
**Seguridad**: Garantizar que solo los usuarios autorizados puedan acceder a los datos y generar informes.
**Escalabilidad**: La infraestructura debe permitir la inclusión de nuevas dimensiones o métricas de análisis sin afectar el rendimiento.

### Herramientas y Tecnologías Utilizadas
Microsoft SQL Server: Para la gestión de la base de datos, DataMart y tabla de hechos.
**SQL Server Integration Services (SSIS)**: Para la carga de datos (ETL).
**SQL Server Analysis Services (SSAS)**: Para análisis multidimensional mediante cubos OLAP.
**SQL Server Reporting Services (SSRS)**: Para generación de informes interactivos.
**SQL Server Agent**: Para la automatización de la carga de datos y ejecución de paquetes SSIS.

**Dashboard de Usuario**: En la primera versión del proyecto (2010), se desarrolló un dashboard en **VB** para la visualización de indicadores clave, mientras que en la segunda versión (2014) el dashboard fue reescrito y optimizado en **C#** para mejorar la interfaz de usuario y la integración con otras herramientas.

### Flujo de Datos y Arquitectura
Extracción de Datos: Los datos de diversas fuentes operacionales se extraen mediante SSIS.
Transformación en Sales Staging: Los datos se limpian, transforman y preparan para ser cargados en el DataMart.
Carga al DataMart: Los datos transformados se cargan en el DataMart, organizados en dimensiones y hechos.
Análisis y Reportes: Mediante SSAS se crean cubos OLAP para realizar análisis multidimensionales, y con SSRS se generan informes para los tomadores de decisiones.

## Requerimientos de los Usuarios Finales
Usuarios de Negocio: Requieren informes dinámicos de ventas, con la posibilidad de filtrar y explorar los datos por cliente, producto y región.
Analistas de Datos: Necesitan acceso a herramientas de análisis avanzado mediante cubos OLAP.
Administradores del Sistema: Serán responsables de mantener el flujo ETL y garantizar la seguridad y disponibilidad del sistema.

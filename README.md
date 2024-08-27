# ABCRetail Dashboard

## Overview

ABCRetail Dashboard is a web application built with ASP.NET Core MVC that allows users to manage various resources, including images, customer profiles, orders, and contracts, using Azure Storage services. This application interacts with Azure Blob Storage, Azure Table Storage, Azure Queue Storage, and Azure File Share to store and manage data.

## Features

- **Upload Image:** Upload images to Azure Blob Storage.
- **Add Customer Profile:** Add customer profiles to Azure Table Storage.
- **Process Order:** Send order processing messages to Azure Queue Storage.
- **Upload Contract:** Upload contracts to Azure File Share.

## Project Structure

The project follows a typical ASP.NET Core MVC structure with controllers, models, views, and services.

### 1. **Controllers**
   - **HomeController:** Manages the operations for uploading images, adding customer profiles, processing orders, and uploading contracts.

### 2. **Models**
   - **CustomerProfile:** Represents a customer profile with properties like `FirstName`, `LastName`, `Email`, and `PhoneNumber`. Implements `ITableEntity` to be stored in Azure Table Storage.

### 3. **Services**
   - **BlobService:** Handles operations related to Azure Blob Storage (e.g., uploading images).
   - **TableService:** Manages CRUD operations for Azure Table Storage.
   - **QueueService:** Sends messages to Azure Queue Storage for order processing.
   - **FileService:** Manages file uploads to Azure File Share.

### 4. **Views**
   - **Index.cshtml:** The main dashboard where users can interact with the application to perform various operations.

## Prerequisites

- .NET 6.0 SDK or later
- Azure Storage Account

## Configuration

Update the `appsettings.json` file with your Azure Storage connection string:

```json
{
  "AzureStorage": {
    "ConnectionString": "Your_Azure_Storage_Connection_String"
  }
}

Usage
Upload Image

Navigate to the "Upload Image" section.
Select an image file and click "Upload Image".
The image will be stored in the images container in Azure Blob Storage.
Add Customer Profile

Enter customer details (First Name, Last Name, Email, Phone Number).
Click "Add Profile".
The profile will be stored in the CustomerID table in Azure Table Storage.
Process Order

Enter the Order ID.
Click "Process Order".
The order will be sent to the order-processing queue in Azure Queue Storage.
Upload Contract

Navigate to the "Upload Contract" section.
Select a contract file and click "Upload Contract".
The contract will be uploaded to the contracts-log file share in Azure File Share.


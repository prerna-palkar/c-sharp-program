using Azure.Storage.Blobs;

string connectionString = 
    "your_blob_storage_connection_string";

BlobServiceClient blobServiceClient =
    new BlobServiceClient(connectionString);

BlobContainerClient containerClient =
    blobServiceClient.GetBlobContainerClient("files");

await containerClient.CreateIfNotExistsAsync();

string filePath = "demo.txt";

BlobClient blobClient =
    containerClient.GetBlobClient("demo.txt");

using FileStream uploadFileStream =
    File.OpenRead(filePath);

await blobClient.UploadAsync(
    uploadFileStream,
    overwrite: true);

uploadFileStream.Close();

Console.WriteLine("File Uploaded Successfully");

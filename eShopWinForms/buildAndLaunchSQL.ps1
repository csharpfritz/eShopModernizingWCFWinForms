docker build -t eshopdemocontainer .
docker run -d -p 15788:1433 -e sa_password=Testing11@@ -e ACCEPT_EULA=Y --name sqlContainer eshopdemocontainer
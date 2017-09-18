docker build -t eshop-wcf-container:latest .
docker run -itd --name eShopWCFHost eshop-wcf-container
docker inspect -f="{{range .NetworkSettings.Networks}}{{.IPAddress}}{{end}}" eShopWCFHost
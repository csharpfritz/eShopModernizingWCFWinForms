docker-compose stop
docker-compose -f docker-compose.yml -f docker-compose.override.yml build
docker-compose up -d
$wcfAddr = docker inspect -f '{{range .NetworkSettings.Networks}}{{.IPAddress}}{{end}}' eshopwinformsmodernized_eshopwcfservice_1
$webApiAddr = docker inspect -f '{{range .NetworkSettings.Networks}}{{.IPAddress}}{{end}}' eshopwinformsmodernized_discountservice_1

$dir = [IO.Path]::GetDirectoryName($MyInvocation.MyCommand.Path)
$configDir = [IO.Path]::Combine($dir, 'eShopWinForms\App.config')
$config = New-Object XML
$config.Load($configDir)

foreach($keys in $config.configuration.appSettings.add)
{
    $keys.key = "DiscountServiceAddress"
    $keys.value = "http://" + $webApiAddr
}

$endpoint = $config.configuration.'system.serviceModel'.client.endpoint
$endpoint.address = "http://" + $wcfAddr + ":80/CatalogService.svc"

$config.save($configDir)
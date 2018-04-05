 # Delete all containers
 Write-Host "Deleting all running containers in the local Docker Host"
 docker rm $(docker ps -a -q) -f

$bliztafreeImagesToDelete = docker images --filter=reference="bliztafree/*" -q
If (-Not $bliztafreeImagesToDelete) {Write-Host "Not deleting bliztafree images as there are no bliztafree images in the current local Docker repo."} 
Else 
{    
    # Delete all bliztafree images
    Write-Host "Deleting bliztafree images in local Docker repo"
    Write-Host $bliztafreeImagesToDelete
    docker rmi $(docker images --filter=reference="bliztafree/*" -q) -f
}

$VSImagesToDelete = docker images --filter=reference="catalog.api:dev" -q
If (-Not $VSImagesToDelete) {Write-Host "Not deleting VS images as there are no VS images in the current local Docker repo."} 
Else 
{    
    # Delete all bliztafree images
    Write-Host "Deleting images created by VS in local Docker repo"
    Write-Host $VSImagesToDelete
    docker rmi $(docker images --filter=reference="*:dev" -q) -f
    
    #docker rmi $(docker images --filter=reference="bliztafree/payment.api:dev" -q) -f
    #docker rmi $(docker images --filter=reference="bliztafree/webspa:dev" -q) -f
    #docker rmi $(docker images --filter=reference="bliztafree/webmvc:dev" -q) -f
    #docker rmi $(docker images --filter=reference="bliztafree/catalog.api:dev" -q) -f
    #docker rmi $(docker images --filter=reference="bliztafree/marketing.api:dev" -q) -f
    #docker rmi $(docker images --filter=reference="bliztafree/ordering.api:dev" -q) -f
    #docker rmi $(docker images --filter=reference="bliztafree/basket.api:dev" -q) -f
    #docker rmi $(docker images --filter=reference="bliztafree/identity.api:dev" -q) -f
    #docker rmi $(docker images --filter=reference="bliztafree/locations.api:dev" -q) -f
    #docker rmi $(docker images --filter=reference="bliztafree/webstatus:dev" -q) -f
}

# DELETE ALL IMAGES AND CONTAINERS

# Delete all containers
# docker rm $(docker ps -a -q) -f

# Delete all images
# docker rmi $(docker images -q)

#Filter by image name (Has to be complete, cannot be a wildcard)
#docker ps -q  --filter=ancestor=bliztafree/identity.api:dev


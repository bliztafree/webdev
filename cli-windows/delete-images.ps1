$imagesToDelete = docker images --filter=reference="bliztafree/*" -q

If (-Not $imagesToDelete) {Write-Host "Not deleting bliztafree images as there are no bliztafree images in the current local Docker repo."} 
Else 
{
    # Delete all containers
    Write-Host "Deleting all containers in local Docker Host"
    docker rm $(docker ps -a -q) -f
    
    # Delete all bliztafree images
    Write-Host "Deleting bliztafree images in local Docker repo"
    Write-Host $imagesToDelete
    docker rmi $(docker images --filter=reference="bliztafree/*" -q) -f
}


# DELETE ALL IMAGES AND CONTAINERS

# Delete all containers
# docker rm $(docker ps -a -q) -f

# Delete all images
# docker rmi $(docker images -q)

#Filter by image name (Has to be complete, cannot be a wildcard)
#docker ps -q  --filter=ancestor=bliztafree/identity.api:dev


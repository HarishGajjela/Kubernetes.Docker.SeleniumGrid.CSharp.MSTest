cd D:\Selenium\Project\SeleniumCSharp\SeleniumCSharp\Yml_BatFiles
kubectl create -f selenium-hub-deployment.yaml REM Creates Selenium Hub Pod
timeout 5
kubectl expose deployment selenium-hub-deployment --type=NodePort --port=4444 REM Exposes the Private port to External Port
timeout 5
kubectl create -f selenium-node-chrome-deployment.yaml REM creates a chrome pod with single instance
timeout 5
kubectl create -f selenium-node-firefox-deployment.yaml REM creates a firefoc pod with single instance
timeout 5
kubectl scale deployment.apps/selenium-node-chrome-deployment --replicas=2 REM creates chrome node with 2 
timeout 5
kubectl scale deployment.apps/selenium-node-firefox-deployment --replicas=2 REM creates firefox node with 2 
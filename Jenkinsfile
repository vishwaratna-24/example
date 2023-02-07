pipeline {
    agent any

    stages {
        stage('Build') {
            steps {
                echo 'build'
            }
        }
        
        stage('Docker Build') {
            steps {
                 
                  powershell 'docker build -f example/Dockerfile -t iamakki/example .'
                     
            }
        }
        stage('Push Image to Docker hub'){
            steps{
                powershell 'docker login -u iamakki -p cpucxb815946!'
                powershell 'docker push iamakki/example'
            }
        }
        stage('Deploy') {
            steps {
                powershell 'docker run -p 8081:80 iamakki/example'
            }
        }
        
    }
}

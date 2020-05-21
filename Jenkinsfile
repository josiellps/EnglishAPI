pipeline {
  agent any
  stages {
    stage('Clone') {
      steps {
        git(url: 'https://github.com/josiellps/', branch: 'develop', credentialsId: 'josiellps')
      }
    }

    stage('Build') {
      steps {
        sh '''dotnet restore
dotnet build'''
      }
    }

    stage('Testes') {
      steps {
        sh 'dotnet test'
      }
    }

    stage('Docker Build') {
      steps {
        sh 'docker build -t englishAPI .'
      }
    }

    stage('Deploy') {
      steps {
        sh 'docker stack deploy --compose-file homolog.yml englishAPI'
      }
    }

  }
}
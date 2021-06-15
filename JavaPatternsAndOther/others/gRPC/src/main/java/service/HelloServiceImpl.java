package service;

import dev.gaudnik.grpc.HelloRequest;
import dev.gaudnik.grpc.HelloResponse;
import dev.gaudnik.grpc.HelloServiceGrpc.HelloServiceImplBase;
import io.grpc.stub.StreamObserver;

public class HelloServiceImpl extends HelloServiceImplBase {
	@Override
	public void hello(HelloRequest request, StreamObserver<HelloResponse> responseStreamObserver) {
		System.out.println(request);
		String greeting = "Hello, " +
				request.getFirstName() +
				" " +
				request.getLastName() +
				" added by server";

		HelloResponse response = HelloResponse.newBuilder()
				.setGreeting(greeting)
				.build();

		responseStreamObserver.onNext(response);
		responseStreamObserver.onCompleted();
	}
}

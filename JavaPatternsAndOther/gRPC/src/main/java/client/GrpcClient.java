package client;

import dev.gaudnik.grpc.HelloRequest;
import dev.gaudnik.grpc.HelloResponse;
import dev.gaudnik.grpc.HelloServiceGrpc;
import io.grpc.ManagedChannel;
import io.grpc.ManagedChannelBuilder;

public class GrpcClient {
	public static void main(String[] args) {
		ManagedChannel channel = ManagedChannelBuilder.forAddress("localhost", 8080)
				.usePlaintext()
				.build();

		HelloServiceGrpc.HelloServiceBlockingStub stub = HelloServiceGrpc.newBlockingStub(channel);

		HelloResponse helloResponse = stub.hello(HelloRequest.newBuilder()
				.setFirstName("Wojciech ch ch")
				.setLastName("Gaudnik k k 666 ")
				.build());

		channel.shutdown();
		System.out.println(helloResponse);
	}
}

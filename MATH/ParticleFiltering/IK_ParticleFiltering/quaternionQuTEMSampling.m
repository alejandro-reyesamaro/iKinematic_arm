%Tohannic Project in Matlab
% author: Antoni Jaume i Capó
% version: 1.0
% date: 24/03/2010
% function: quaternionQuTEMSampling [Thesis M:P: Johnson, MIT 2003]
% description:  QuTEM sampling of unit quaternions
%               input: m = (quaternion de la configuració actual = chain
%               configuration) Eigenvalues of covariance, sigma1, sigma2,
%               sigma3 - samples = number of samples. 
%               output: samples quaternion matrix  (samples is number of rows)
function [q]=quaternionQuTEMSampling(m,pg,samples)
%s1=s2=s3 =>uniform Sampling
x=normrnd(0,1,[samples,3]);%2
for i = 1:samples%3
    x(i,:)=x(i,:)/norm(x(i,:));
end
N=[pg(2)*x(:,1),pg(3)*x(:,2),pg(4)*x(:,3)];%4
theta=normrnd(0,pg(1),[samples,1]);%5
for i = 1:samples%3
        q(i,:)=quaternionProduct(m(i).q,quaternionExponentialMap([N(i,:)*theta(i)]));%6
end

%--------------------------------------------------------------------------
# OS.Common
ͨ�û���ʵ�֣���ǰ���Ա�׼�����ʽ�ṩ����net46��֧���б�׼���Framework 4.6�������汾ʵ�ְ�  
��������⣬Ҳ�����ڹ��ں�(OSSCore)������:  
![OSSCore](http://img1.static.OSSCore.com/wei_qr.jpg)  

��ǰ�����Ҫ�ṩ���µ����ݣ�  
1. �����û�ϵͳ�豸��Ϣʵ�嶨�塣
2. �����ӽ��ܷ���ʵ�֣���
3. ����ʵ��DTOת������̬��չ������ʱ�䣬�ַ����ȵȴ���
4. ������־�����棬���ø�����̬�༰Ĭ�Ϸ���ʵ��
5. ȫ�ֽ������ҳʵ�嶨��

## Authrization
 �û���Ȩ��Ϣģ�飬��������������ʹ��MemberShiper��������Ҫ�����������ԣ�  

 1. AppAuthorize   
	��Ӧ����Ӧ����Ȩ��Ϣ��Ҫ��Ӧ����Դ���ͻ��˵����͵�
 2. Identity   
	��Ӧ���ǵ�ǰ���û���Ϣ���û����� ��  
 MemberShiper ���ṩ��GetToken��������������û�Id��ͬʱ��һ����Ӧ��GetTokenDetail����token�н����û�id��Ϣ  
 ʹ�õ��Ǽ��ܷ�ʽΪAes����

## BasicImpls
  ϵͳĬ��ʵ����Ϣ��Ӧ������ʵ�壬����BaseMo����ͨ��״̬ö��
  ͨ����Ӧʵ��Resp��������IdResp,LongIdResp,ListResp��PageListResp�����Լ���Ӧ�����չ����ʵ�֡�

## Encrypt
 ϵͳ���ܻ����⣬��Ҫ������  
 md5��Md5��,aes��AesRijndael��,sha1��Sha1��,hmac��HMACSHA��-����sha���ܷ�ʽ�⼸�ּ����㷨  

## Extention
 ϵͳ��չ��������Ҫ������  
 �ַ���ת����չ���磺 "0".ToInt32()��"xxx".Base64UrlEncode()��  
 ʱ��ת����չ���磺DateTime.Now.ToUtcSeconds() ��  
Task��չ�������磺 Task.WaitResult() ��  
UrlCode��չ�������� "name=n&code=1".UrlEncode();  
ö����չ�������磺 typeof(Enum).ToEnumDirs();  
xml���л���չ������ �磺 "<xml><name>test</name></xml>".DeserializeXml<Type>();  


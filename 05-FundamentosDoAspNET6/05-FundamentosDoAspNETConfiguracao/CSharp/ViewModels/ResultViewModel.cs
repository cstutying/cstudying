using System.Runtime.InteropServices.JavaScript;

namespace CSharp.ViewModels;

public class ResultViewModel<T>
{
  // RECEBO O DATA E OS ERROS
  public ResultViewModel(T data, List<string> errors)
  {
    Data = data;
    Errors = errors;
  }

  // SÓ VAI RECEBER SE DER CERTO 
  public ResultViewModel(T data)
  {
    Data = data;
  }

  // SÓ VAI RECEBER SE DER ERRADO
  public ResultViewModel(List<string> errors)
  {
    Errors = errors;
  }

  // SÓ RECEBO DE DER APENAS UMA STRING DE ERRO
  public ResultViewModel(string error)
  {
    Errors.Add(error);
  }

  public T Data { get; private set; }
  public List<string> Errors { get; private set; } = new();
}
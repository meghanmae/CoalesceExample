import * as $metadata from './metadata.g'
import * as $models from './models.g'
import { AxiosPromise, AxiosRequestConfig, ModelApiClient, ServiceApiClient, ItemResult, ListResult } from 'coalesce-vue/lib/api-client'

export class ApplicationUserApiClient extends ModelApiClient<$models.ApplicationUser> {
  constructor() { super($metadata.ApplicationUser) }
}


export class EventApiClient extends ModelApiClient<$models.Event> {
  constructor() { super($metadata.Event) }
}


export class OrganizationApiClient extends ModelApiClient<$models.Organization> {
  constructor() { super($metadata.Organization) }
}


export class TriviaAnswerApiClient extends ModelApiClient<$models.TriviaAnswer> {
  constructor() { super($metadata.TriviaAnswer) }
}


export class TriviaGuessApiClient extends ModelApiClient<$models.TriviaGuess> {
  constructor() { super($metadata.TriviaGuess) }
}


export class TriviaQuestionApiClient extends ModelApiClient<$models.TriviaQuestion> {
  constructor() { super($metadata.TriviaQuestion) }
}


export class TriviaQuestionTagApiClient extends ModelApiClient<$models.TriviaQuestionTag> {
  constructor() { super($metadata.TriviaQuestionTag) }
}


export class TriviaTagApiClient extends ModelApiClient<$models.TriviaTag> {
  constructor() { super($metadata.TriviaTag) }
}


